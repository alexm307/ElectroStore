@ModelType ElectroStore2.Phone
@Code
    ViewData("Title") = "Details"
End Code
<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
    <h2>Details</h2>

    <div>
        <h4>Phone</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Name)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ElectronicProduct.Name)
            </dd>
            <dt>
                @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Price)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ElectronicProduct.Price)
            </dd>
            <dt>
                @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Rating)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ElectronicProduct.Rating)
            </dd>
            <dt>
                @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Quantity)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ElectronicProduct.Quantity)
            </dd>
            <dt>
                @Html.DisplayNameFor(Function(model) model.ElectronicProduct.Colour)
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ElectronicProduct.Colour)
            </dd>

            @*<dt>
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
                </dd>*@


        </dl>
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With {.id = Model.PhoneID}) |
        @Html.ActionLink("Back to List", "Index")
    </p>


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
