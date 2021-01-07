Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ElectroStore2

Namespace Controllers
    Public Class KitchenAppliancesController
        Inherits System.Web.Mvc.Controller

        Private db As New SQLServerDBEntities1

        ' GET: KitchenAppliances
        Function Index() As ActionResult
            Dim kitchenAppliances = db.KitchenAppliances.Include(Function(k) k.Dishwasher).Include(Function(k) k.ElectronicProduct).Include(Function(k) k.Refrigerator).Include(Function(k) k.WashingMachine)
            Return View(kitchenAppliances.ToList())
        End Function

        ' GET: KitchenAppliances/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim kitchenAppliance As KitchenAppliance = db.KitchenAppliances.Find(id)
            If IsNothing(kitchenAppliance) Then
                Return HttpNotFound()
            End If
            Return View(kitchenAppliance)
        End Function

        ' GET: KitchenAppliances/Create
        Function Create() As ActionResult
            ViewBag.ApplianceID = New SelectList(db.Dishwashers, "DishwasherID", "LoadingCapacity")
            ViewBag.ApplianceID = New SelectList(db.ElectronicProducts, "ProductID", "Name")
            ViewBag.ApplianceID = New SelectList(db.Refrigerators, "RefrigeratorID", "Volume")
            ViewBag.ApplianceID = New SelectList(db.WashingMachines, "WashID", "LoadingType")
            Return View()
        End Function

        ' POST: KitchenAppliances/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ApplianceID,AnnualEnergyConsumption_kWh,EuEnergyLabel,SoundLevels")> ByVal kitchenAppliance As KitchenAppliance) As ActionResult
            If ModelState.IsValid Then
                db.KitchenAppliances.Add(kitchenAppliance)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ApplianceID = New SelectList(db.Dishwashers, "DishwasherID", "LoadingCapacity", kitchenAppliance.ApplianceID)
            ViewBag.ApplianceID = New SelectList(db.ElectronicProducts, "ProductID", "Name", kitchenAppliance.ApplianceID)
            ViewBag.ApplianceID = New SelectList(db.Refrigerators, "RefrigeratorID", "Volume", kitchenAppliance.ApplianceID)
            ViewBag.ApplianceID = New SelectList(db.WashingMachines, "WashID", "LoadingType", kitchenAppliance.ApplianceID)
            Return View(kitchenAppliance)
        End Function

        ' GET: KitchenAppliances/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim kitchenAppliance As KitchenAppliance = db.KitchenAppliances.Find(id)
            If IsNothing(kitchenAppliance) Then
                Return HttpNotFound()
            End If
            ViewBag.ApplianceID = New SelectList(db.Dishwashers, "DishwasherID", "LoadingCapacity", kitchenAppliance.ApplianceID)
            ViewBag.ApplianceID = New SelectList(db.ElectronicProducts, "ProductID", "Name", kitchenAppliance.ApplianceID)
            ViewBag.ApplianceID = New SelectList(db.Refrigerators, "RefrigeratorID", "Volume", kitchenAppliance.ApplianceID)
            ViewBag.ApplianceID = New SelectList(db.WashingMachines, "WashID", "LoadingType", kitchenAppliance.ApplianceID)
            Return View(kitchenAppliance)
        End Function

        ' POST: KitchenAppliances/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ApplianceID,AnnualEnergyConsumption_kWh,EuEnergyLabel,SoundLevels")> ByVal kitchenAppliance As KitchenAppliance) As ActionResult
            If ModelState.IsValid Then
                db.Entry(kitchenAppliance).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ApplianceID = New SelectList(db.Dishwashers, "DishwasherID", "LoadingCapacity", kitchenAppliance.ApplianceID)
            ViewBag.ApplianceID = New SelectList(db.ElectronicProducts, "ProductID", "Name", kitchenAppliance.ApplianceID)
            ViewBag.ApplianceID = New SelectList(db.Refrigerators, "RefrigeratorID", "Volume", kitchenAppliance.ApplianceID)
            ViewBag.ApplianceID = New SelectList(db.WashingMachines, "WashID", "LoadingType", kitchenAppliance.ApplianceID)
            Return View(kitchenAppliance)
        End Function

        ' GET: KitchenAppliances/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim kitchenAppliance As KitchenAppliance = db.KitchenAppliances.Find(id)
            If IsNothing(kitchenAppliance) Then
                Return HttpNotFound()
            End If
            Return View(kitchenAppliance)
        End Function

        ' POST: KitchenAppliances/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim kitchenAppliance As KitchenAppliance = db.KitchenAppliances.Find(id)
            db.KitchenAppliances.Remove(kitchenAppliance)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
