@ModelType ElectroStore2.KitchenAppliance
@Code
    ViewData("Title") = "Details"
End Code
<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
    <h2>Details</h2>

    <div>
        <h4>KitchenAppliance</h4>
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
                    @Html.DisplayNameFor(Function(model) model.AnnualEnergyConsumption_kWh)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.AnnualEnergyConsumption_kWh)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.EuEnergyLabel)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.EuEnergyLabel)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.SoundLevels)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.SoundLevels)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.Dishwasher.LoadingCapacity)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.Dishwasher.LoadingCapacity)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Name)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.ElectronicProduct.Name)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.Refrigerator.Volume)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.Refrigerator.Volume)
                </dd>

                <dt>
                    @Html.DisplayNameFor(Function(model) model.WashingMachine.LoadingType)
                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.WashingMachine.LoadingType)
                </dd>*@

        </dl>
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With {.id = Model.ApplianceID}) |
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
