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
    Public Class WashingMachinesController
        Inherits System.Web.Mvc.Controller

        Private db As New SQLServerDBEntities1

        ' GET: WashingMachines
        Function Index() As ActionResult
            Dim washingMachines = db.WashingMachines.Include(Function(w) w.KitchenAppliance)
            Return View(washingMachines.ToList())
        End Function

        ' GET: WashingMachines/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim washingMachine As WashingMachine = db.WashingMachines.Find(id)
            If IsNothing(washingMachine) Then
                Return HttpNotFound()
            End If
            Return View(washingMachine)
        End Function

        ' GET: WashingMachines/Create
        Function Create() As ActionResult
            ViewBag.WashID = New SelectList(db.KitchenAppliances, "ApplianceID", "ApplianceID")
            Return View()
        End Function

        ' POST: WashingMachines/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="WashID,LoadingType,LoadingCapacity,NoOfPrograms")> ByVal washingMachine As WashingMachine) As ActionResult
            If ModelState.IsValid Then
                db.WashingMachines.Add(washingMachine)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.WashID = New SelectList(db.KitchenAppliances, "ApplianceID", "ApplianceID", washingMachine.WashID)
            Return View(washingMachine)
        End Function

        ' GET: WashingMachines/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim washingMachine As WashingMachine = db.WashingMachines.Find(id)
            If IsNothing(washingMachine) Then
                Return HttpNotFound()
            End If
            ViewBag.WashID = New SelectList(db.KitchenAppliances, "ApplianceID", "ApplianceID", washingMachine.WashID)
            Return View(washingMachine)
        End Function

        ' POST: WashingMachines/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="WashID,LoadingType,LoadingCapacity,NoOfPrograms")> ByVal washingMachine As WashingMachine) As ActionResult
            If ModelState.IsValid Then
                db.Entry(washingMachine).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.WashID = New SelectList(db.KitchenAppliances, "ApplianceID", "ApplianceID", washingMachine.WashID)
            Return View(washingMachine)
        End Function

        ' GET: WashingMachines/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim washingMachine As WashingMachine = db.WashingMachines.Find(id)
            If IsNothing(washingMachine) Then
                Return HttpNotFound()
            End If
            Return View(washingMachine)
        End Function

        ' POST: WashingMachines/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim washingMachine As WashingMachine = db.WashingMachines.Find(id)
            db.WashingMachines.Remove(washingMachine)
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
