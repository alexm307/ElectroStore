@ModelType ElectroStore2.Refrigerator
@Code
    ViewData("Title") = "Details"
End Code
<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
    <h2>Details</h2>

    <div>
        <h4>Refrigerator</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.KitchenAppliance.ElectronicProduct.Name)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.KitchenAppliance.ElectronicProduct.Name)
            </dd>
            <dt>
                @Html.DisplayNameFor(Function(model) model.KitchenAppliance.ElectronicProduct.Price)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.KitchenAppliance.ElectronicProduct.Price)
            </dd>
            <dt>
                @Html.DisplayNameFor(Function(model) model.KitchenAppliance.ElectronicProduct.Rating)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.KitchenAppliance.ElectronicProduct.Rating)
            </dd>
            <dt>
                @Html.DisplayNameFor(Function(model) model.KitchenAppliance.ElectronicProduct.Quantity)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.KitchenAppliance.ElectronicProduct.Quantity)
            </dd>
            <dt>
                @Html.DisplayNameFor(Function(model) model.KitchenAppliance.ElectronicProduct.Colour)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.KitchenAppliance.ElectronicProduct.Colour)
            </dd>

        </dl>
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With {.id = Model.RefrigeratorID}) |
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
