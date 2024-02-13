using Autofac;
using Business.Abstract;
using Business.Concrete;
using Data_Access.Abstarct;
using Data_Access.Concrete.Entity_Framework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dependency_Resolvers.AutoFac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<efCarDal>().As<ICarDal>().SingleInstance();
            builder.RegisterType<RentACarContext>().As<RentACarContext>().SingleInstance();
        }
    }
}
