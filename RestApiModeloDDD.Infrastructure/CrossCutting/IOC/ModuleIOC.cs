﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder buider)
        {
            ConfigurationIOC.Load(buider);
        }
    }
}
