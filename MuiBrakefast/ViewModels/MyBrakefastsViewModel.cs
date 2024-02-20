using CommunityToolkit.Mvvm.ComponentModel;
using MuiBrakefast.Models;

namespace MuiBrakefast.ViewModels;
    public partial class MyBrakefastsViewModel : ObservableObject
    {
          [ObservableProperty]
         List<Brakefast> brakefasts;

    public MyBrakefastsViewModel()
    {
        LoadBreakfast();
    }

    private void LoadBreakfast()
    {
        Brakefasts = new()
       {
           new Brakefast(
               Name: "Vegan All The Way",
               Description:"Everything is Vegan Please join us for a healthy meal",
               StartDateTime: DateTime.UtcNow.AddDays(1),
               EndDateTime: DateTime.UtcNow.AddDays(1).AddHours(1),
               Image: new Uri("https://images.unsplash.com/photo-1515942400420-2b98fed1f515?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"),
               Savory: new List<string>{"Bread", "Avocado", "Cherry Tomatoes"},
               Sweets: new List<string>{"Vegan Cookie"}),
            new Brakefast(
               Name: "The real treat ",
               Description:"Hy I am Mihai and i will be your Chef today",
               StartDateTime: DateTime.UtcNow,
               EndDateTime: DateTime.UtcNow.AddHours(2),
               Image: new Uri("https://img.freepik.com/free-photo/close-up-delicious-breakfast-with-lettuce-egg_23-2148543692.jpg?w=1380&t=st=1708426204~exp=1708426804~hmac=1e098096c3c0e5120a5cc8668bd24e4d9f8d3bf83d085b09e1eccfde40063850"),
               Savory: new List<string>{"Bread", "Egs", "Bacon"},
               Sweets: new List<string>{"American Pancakes", "Waffle"})
       };
    }
}

