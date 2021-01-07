@ModelType ElectroStore2.LaptopCPU
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>LaptopCPU</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Brand)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Brand)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NumberOfCores)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NumberOfCores)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Frequency_mHz)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Frequency_mHz)
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
