using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiBrakefast.Models;

namespace MauiBrakefast.ViewModels;
    public partial class MyBrakefastsViewModel : ObservableObject
    {
          [ObservableProperty]
          List<Brakefast> brakefasts;
          [ObservableProperty]
          bool isRefreshing;

    public MyBrakefastsViewModel()
    {
        LoadBreakfastAsync();
    }
    [RelayCommand]
    public async Task LoadBreakfastAsync()
    {
        try
        {
           await Task.Delay(2000);
           Brakefasts = new()
           {
           new Brakefast(
               Name: "Vegan All The Way",
               Description:"Everything is Vegan Please join us for a healthy meal",
               StartDateTime: DateTime.UtcNow.AddDays(1),
               EndDateTime: DateTime.UtcNow.AddDays(1).AddHours(1),
               Image: new Uri("https://plus.unsplash.com/premium_photo-1699563104922-139d885755d7?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"),
               Savory: new List<string>{"Bread", "Avocado", "Chery Taomatoes"},
               Sweets: new List<string>{"Vegan Cookie"}),
            new Brakefast(
               Name: "The real treat ",
               Description:"Hy I am Mihai and i will be your Chef today",
               StartDateTime: DateTime.UtcNow,
               EndDateTime: DateTime.UtcNow.AddHours(2),
               Image: new Uri("https://images.unsplash.com/photo-1525351484163-7529414344d8?q=80&w=2080&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"),
               Savory: new List<string>{"Bread", "Egs", "Bacon"},
               Sweets: new List<string>{"American Pancakes", "Waffle"})
           };
        }
        finally 
        { 
            IsRefreshing = false;
        }
        
    }
}

