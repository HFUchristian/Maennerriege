﻿using System;
using Wettkampf.Models;
using Wettkampf.Services;
using JetBrains.Annotations;
using SimpleInjector;
using Wettkampf.ViewModels;

namespace Wettkampf.Core
{
  public static class ContainerExtensions
  {
    public static Container CreateContainer()
    {
      return new Container()
      {
        Options =
        {
          ResolveUnregisteredConcreteTypes = true,
          AllowOverridingRegistrations = true
        }
      };
    }

    public static Container RegisterWettkampfServices([NotNull] this Container container)
    {
      if (container is null) { throw new ArgumentNullException(nameof(container)); }

      container.RegisterSingleton<IDataStore<Verein>, SQLiteDataStore<Verein>>();
      container.RegisterSingleton<IDialogService, DialogService>();
      container.RegisterSingleton<IVereinSaver, VereinSaver>();
      container.RegisterSingleton<IItemFactory<Verein>, VereinFactory>();

      return container;
    }
  }
}