@Code
    ViewData("Title") = "Home Page"
End Code

<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
  
    <div>

        <img src="https://www.pcgarage.ro/images/other/13/57962dfcbc62075aa286821b5d8af2e3.png" alt="Yes" />


        <h1>
            Electronic Products <br />
            <h2>
                @Html.ActionLink("Main details of the products", "Index", "ElectronicProducts") <br>
            </h2>

        </h1>


        <h1>
            Laptops <br />
            <h2>
                @Html.ActionLink("Laptops", "Index", "Laptops") <br>
                @Html.ActionLink("CPUs", "Index", "LaptopCPUs") <br>
                @Html.ActionLink("GPUs", "Index", "LaptopGPUs") <br>
            </h2>

        </h1>

        <h1>
            Kitchen Appliances <br />
            <h2>
                @Html.ActionLink("Kitchen Appliances - General Details", "Index", "KitchenAppliances") <br>
                @Html.ActionLink("Refrigerators", "Index", "Refrigerators") <br>
                @Html.ActionLink("Dishwashers", "Index", "Dishwashers") <br>
                @Html.ActionLink("Washing Machines", "Index", "WashingMachines") <br>
            </h2>

        </h1>

        <h1>
            Phones <br />
            <h2>
                @Html.ActionLink("Phones", "Index", "Phones") <br>
            </h2>

        </h1>


    </div>
