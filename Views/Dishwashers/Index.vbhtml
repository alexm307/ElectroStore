@ModelType IEnumerable(Of ElectroStore2.Dishwasher)
@Code
ViewData("Title") = "Index"
End Code
<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
    <h2>Index</h2>

    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.KitchenAppliance.ElectronicProduct.Name)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.NoOfPrograms)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.StepsOfTemperature)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.LoadingCapacity)
            </th>
            <th></th>
        </tr>

        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.KitchenAppliance.ElectronicProduct.Name)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.NoOfPrograms)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.StepsOfTemperature)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.LoadingCapacity)
                </td>

                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.DishwasherID}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.DishwasherID})
                </td>
            </tr>
        Next

    </table>
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
    <br />
    <br />
