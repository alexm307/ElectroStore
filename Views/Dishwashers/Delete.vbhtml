@ModelType ElectroStore2.Dishwasher
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Dishwasher</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.NoOfPrograms)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NoOfPrograms)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.StepsOfTemperature)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.StepsOfTemperature)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LoadingCapacity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LoadingCapacity)
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
