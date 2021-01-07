@ModelType IEnumerable(Of ElectroStore2.LaptopGPU)
@Code
    ViewData("Title") = "Index"
End Code

<div class="polaroid">
    <img src="https://www.amd.com/system/files/2020-09/579976-radeon-6900xt-6800xt-1260x709.png" alt="Laptops" class="center-block" />
</div>

<br />

<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
    <h2>Laptop GPUs</h2>

    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.Brand)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Type)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.DedicatedMemory_GB)
            </th>
            <th></th>
        </tr>

        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Brand)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.Type)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.DedicatedMemory_GB)
                </td>
                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.LaptopGPUID}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.LaptopGPUID})
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
