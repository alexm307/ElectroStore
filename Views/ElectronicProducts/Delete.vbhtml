@ModelType ElectroStore2.ElectronicProduct
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
