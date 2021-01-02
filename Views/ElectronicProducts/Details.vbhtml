@ModelType ElectroStore2.ElectronicProduct
@Code
    ViewData("Title") = "Details"
End Code
<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
<h2>Details</h2>

<div>
    <h4>ElectronicProduct</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Price)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Price)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Rating)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Rating)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Quantity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Quantity)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Colour)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Colour)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.KitchenAppliance.EuEnergyLabel)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.KitchenAppliance.EuEnergyLabel)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Laptop.Brand)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Laptop.Brand)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Phone.PhoneCPU)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Phone.PhoneCPU)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ProductID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
