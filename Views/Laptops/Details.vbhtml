@ModelType ElectroStore2.Laptop
@Code
    ViewData("Title") = "Details"
End Code
<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
    <h2>Details</h2>

    <div>
        <h4>Laptop</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Name)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ElectronicProduct.Name)
            </dd>
            <dt>
                @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Price)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ElectronicProduct.Price)
            </dd>
            <dt>
                @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Rating)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ElectronicProduct.Rating)
            </dd>
            <dt>
                @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Quantity)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ElectronicProduct.Quantity)
            </dd>
            <dt>
                @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Colour)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ElectronicProduct.Colour)
            </dd>

            @*<dt>
                    @Html.DisplayNameFor(Function(model) model.Brand)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.Brand)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.RAM)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.RAM)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.Battery)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.Battery)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.Display)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.Display)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.Storage_GB)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.Storage_GB)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.DisplaySize_inches)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.DisplaySize_inches)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.C2in1Laptops.Touchscreen)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.C2in1Laptops.Touchscreen)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Name)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.ElectronicProduct.Name)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.GamingLaptop.GamingLaptopID)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.GamingLaptop.GamingLaptopID)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.LaptopCPU.Brand)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.LaptopCPU.Brand)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.LaptopGPU.Brand)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.LaptopGPU.Brand)
                </dd>*@

        </dl>
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With {.id = Model.LaptopID}) |
        @Html.ActionLink("Back to List", "Index")
    </p>

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
