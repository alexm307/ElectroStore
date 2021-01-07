@ModelType ElectroStore2.KitchenAppliance
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>KitchenAppliance</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
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
