@ModelType IEnumerable(Of ElectroStore2.Laptop)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Laptops</h2>
<div class="polaroid">
    <img src="https://static.toiimg.com/thumb/msid-71924733,width-1070,height-580,imgsize-164678,resizemode-75,overlay-toi_sw,pt-32,y_pad-40/photo.jpg" alt="Laptops" class="center-block"/>
</div>

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
            @Html.DisplayNameFor(Function(model) model.Brand)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.RAM)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Battery)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Display)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Storage_GB)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DisplaySize_inches)
        </th>


        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.ElectronicProduct.Name)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Brand)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.RAM)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Battery)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Display)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Storage_GB)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.DisplaySize_inches)
            </td>

            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.LaptopID}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.LaptopID}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.LaptopID})
            </td>
        </tr>
    Next

</table>
