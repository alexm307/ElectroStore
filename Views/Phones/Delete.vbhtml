@ModelType ElectroStore2.Phone
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Phone</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.PhoneCPU)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PhoneCPU)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Battery_mAh)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Battery_mAh)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Display)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Display)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Storage_GB)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Storage_GB)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Size_inches)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Size_inches)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ElectronicProduct.Name)
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
