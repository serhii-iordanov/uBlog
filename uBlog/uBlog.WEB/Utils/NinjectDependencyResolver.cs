﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using uBlog.BLL.Interfaces;
using uBlog.BLL.Services;

namespace uBlog.WEB.Utils
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IBlogService>().To<BlogService>();
        }
    }
}