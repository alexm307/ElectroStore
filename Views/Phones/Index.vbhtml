@ModelType IEnumerable(Of ElectroStore2.Phone)
@Code
ViewData("Title") = "Index"
End Code
<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
<h2>Phones</h2>

<img src="https://cdn.vox-cdn.com/thumbor/W0l-CJqtylo_oj0qXATSexh9CrU=/0x0:2040x1360/1200x675/filters:focal(857x517:1183x843)/cdn.vox-cdn.com/uploads/chorus_image/image/68490964/Best_Phone_Grid_2020_v2.0.jpg" alt="Phones" class="center-block" />

<br />
<br />

<p>
    @Html.ActionLink("Create New Phone (Make sure that you have created an electronic product first)", "Create")
</p>

<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PhoneCPU)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Battery_mAh)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Display)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Storage_GB)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Size_inches)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
         <td>
            @Html.DisplayFor(Function(modelItem) item.ElectronicProduct.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PhoneCPU)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Battery_mAh)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Display)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Storage_GB)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Size_inches)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.PhoneID}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PhoneID })
        </td>
    </tr>
Next

</table>
