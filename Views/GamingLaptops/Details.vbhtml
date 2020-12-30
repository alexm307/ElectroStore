@ModelType ElectroStore2.GamingLaptop
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>GamingLaptop</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.RefreshRate_Hz)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RefreshRate_Hz)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ResponseTime_ms)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ResponseTime_ms)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Laptop.Brand)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Laptop.Brand)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.GamingLaptopID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
