@ModelType ElectroStore2.Laptop
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Laptop</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Brand)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Brand)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.RAM)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RAM)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Battery)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Battery)
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
            @Html.DisplayNameFor(Function(model) model.DisplaySize_inches)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DisplaySize_inches)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.C2in1Laptops.Touchscreen)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.C2in1Laptops.Touchscreen)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ElectronicProduct.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.GamingLaptop.GamingLaptopID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.GamingLaptop.GamingLaptopID)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LaptopCPU.Brand)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LaptopCPU.Brand)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LaptopGPU.Brand)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LaptopGPU.Brand)
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
