@ModelType ElectroStore2.LaptopCPU
@Code
    ViewData("Title") = "Details"
End Code
<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
    <h2>Details</h2>

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
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With {.id = Model.LaptopCPUID}) |
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
    <br />
    <br />
