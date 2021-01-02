@ModelType IEnumerable(Of ElectroStore2.KitchenAppliance)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Kitchen Appliances</h2>

<img src="https://mydecorative.com/wp-content/uploads/2019/07/must-have-appliances-for-an-office-kitchen.jpg" alt="Kitchen Appliances" class="center-block" />

<br />
<br />

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.AnnualEnergyConsumption_kWh)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EuEnergyLabel)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SoundLevels)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Dishwasher.LoadingCapacity)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Refrigerator.Volume)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WashingMachine.LoadingType)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.ElectronicProduct.Name)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.AnnualEnergyConsumption_kWh)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.EuEnergyLabel)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.SoundLevels)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Dishwasher.LoadingCapacity)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Refrigerator.Volume)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.WashingMachine.LoadingType)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.ApplianceID}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.ApplianceID}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.ApplianceID})
            </td>
        </tr>
    Next

</table>
