﻿using CommunityToolkit.Mvvm.ComponentModel;
using NavPoint.Core.Models;
using NavPoint.Core.Types;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavPoint.Core.ViewModels;

public partial class Locations : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<LocationUnit> _locationUnits;

    public Locations()
    {
        _locationUnits = LoadLocations();
    }

    private ObservableCollection<LocationUnit> LoadLocations()
    {
        var locations = new ObservableCollection<LocationUnit>();

        locations.Add(new LocationUnit("Home", LocationType.Place, new Coordinates() { XCoordinate = 44.443145, YCoordinate = 26.022156 }));
        locations.Add(new LocationUnit("Work", LocationType.Place, new Coordinates() { XCoordinate = 44.481202, YCoordinate = 26.115779 }));
        locations.Add(new LocationUnit("Stefania", LocationType.People, new Coordinates() { XCoordinate = 44.435427, YCoordinate = 26.023330 }));
            
        //TODO: logic from source e.g. DB

        return locations;
    }
}
