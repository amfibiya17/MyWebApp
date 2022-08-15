ASP.NET App RazorPagesPizza
===

Link for deployed application -->> [RazorPagesPizza](https://razorpagespizza.azurewebsites.net/)

## What is this project about

- In this project, I examined the Razor Pages architecture in an ASP.NET Core app
- This app provided a UI for updating and deleting product listings exposed through a web API endpoint
- I added a product creation form, taking advantage of Razor Tag Helpers
- With Tag Helpers, it is easy to quickly added client-side and server-side validation. I also gained cross-site antiforgery validation
- I coded its PageModel class that provided a separation of concern for the page's logic operations and data properties
- The app was deployed to Azure 
---

## Examples of usage:

### Main page
![screen1](https://i.postimg.cc/Qt1wsnBX/Screenshot-2022-08-15-at-16-14-04.png)  

### Pizza list page
![screen2](https://i.postimg.cc/mDPZw46m/Screenshot-2022-08-15-at-16-13-54.png)  

### Adding new pizza to the list
![screen3](https://i.postimg.cc/brqCPYcT/Screenshot-2022-08-15-at-16-17-23.png)    

### Deleting pizza from the list
![screen4](https://i.postimg.cc/9f3BVXy7/Screenshot-2022-08-15-at-16-19-34.png)  

---

## How to install the program

- Clone this repository 

```
git clone https://github.com/amfibiya17/MyWebApp.git
```

---

## How to run the program

```
cd MyWebApp
dotnet build
```
Open http://localhost:5253/ in the browser
---