﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Server.ItSelf
{
    public class ControllerHandler : IHandler
    {
        private readonly Assembly _controllerAssembly;
        private readonly Dictionary<string, Func<object>> _routes;

        public ControllerHandler(Assembly controllersAssembly)
        {
            this._routes = controllersAssembly.GetTypes()
                .Where(x => typeof(IController).IsAssignableFrom(x))
                .SelectMany(Controller => Controller.GetMethods().Select(Method => new {
                    Controller,
                    Method
                })
                ).ToDictionary(
                    key => GetPath(key.Controller, key.Method),
                    value => GetEndpointMethod(value.Controller, value.Method)
                );
            // this._controllerAssembly = assembly;
            //this._routes = assembly.GetTypes()
            //    .Where(x => typeof(IController).IsAssignableFrom(x))
            //    .SelectMany(Controller => Controller.GetMethods().Select(Method => new
            //    {
            //        Controller,
            //        Method
            //    })
            //    ).ToDictionary(
            //    key => GetPath(key.Controller, key.Method),
            //    value => GetEndpointMethod(value.Controller, value.Method)
            //    );

        }

        private Func<object> GetEndpointMethod(Type controller, MethodInfo method)
        {
            return () => method.Invoke(Activator.CreateInstance(controller), Array.Empty<object>());
        }

        private string GetPath(Type controller, MethodInfo method)
        {
            string name = controller.Name;
            if (name.EndsWith("controller", StringComparison.InvariantCultureIgnoreCase))
            {
                name = name.Substring(0, name.Length - "controller".Length);
            }
            if (method.Name.Equals("Index", StringComparison.InvariantCultureIgnoreCase))
            {
                return "/" + name;
            }
            return "/" + name + "/" + method.Name;
        }

        public void Handle(Stream stream, Request request)
        {
            if (!_routes.TryGetValue(request.Path, out var func))
                ResponseWriter.WriteStatus(System.Net.HttpStatusCode.NotFound, stream);
            else
            {
                ResponseWriter.WriteStatus(System.Net.HttpStatusCode.OK, stream);
                WriteControllerReponse(func(), stream);
            }
        }

        private void WriteControllerReponse(object response, Stream stream)
        {
            if (response is string str)
            {
                using var writer = new StreamWriter(stream, leaveOpen: true);
                writer.Write(str);
            }
            else if (response is byte[] buffer)
            {
                stream.Write(buffer, 0, buffer.Length);
            }
            else
            {
                WriteControllerReponse(JsonConvert.SerializeObject(response), stream);
            }
        }
    }
}
