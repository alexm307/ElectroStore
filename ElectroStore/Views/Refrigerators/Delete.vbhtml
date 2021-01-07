@ModelType ElectroStore2.Refrigerator
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Refrigerator</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Volume)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Volume)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SpecialCompartiments)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SpecialCompartiments)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NoOfShelves)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NoOfShelves)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.KitchenAppliance.EuEnergyLabel)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.KitchenAppliance.EuEnergyLabel)
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
