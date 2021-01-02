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
    Public Class LaptopGPUsController
        Inherits System.Web.Mvc.Controller

        Private db As New SQLServerDBEntities1

        ' GET: LaptopGPUs
        Function Index() As ActionResult
            Return View(db.LaptopGPUs.ToList())
        End Function

        ' GET: LaptopGPUs/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim laptopGPU As LaptopGPU = db.LaptopGPUs.Find(id)
            If IsNothing(laptopGPU) Then
                Return HttpNotFound()
            End If
            Return View(laptopGPU)
        End Function

        ' GET: LaptopGPUs/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: LaptopGPUs/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="LaptopGPUID,Brand,Name,Type,DedicatedMemory_GB")> ByVal laptopGPU As LaptopGPU) As ActionResult
            If ModelState.IsValid Then
                db.LaptopGPUs.Add(laptopGPU)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(laptopGPU)
        End Function

        ' GET: LaptopGPUs/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim laptopGPU As LaptopGPU = db.LaptopGPUs.Find(id)
            If IsNothing(laptopGPU) Then
                Return HttpNotFound()
            End If
            Return View(laptopGPU)
        End Function

        ' POST: LaptopGPUs/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="LaptopGPUID,Brand,Name,Type,DedicatedMemory_GB")> ByVal laptopGPU As LaptopGPU) As ActionResult
            If ModelState.IsValid Then
                db.Entry(laptopGPU).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(laptopGPU)
        End Function

        ' GET: LaptopGPUs/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim laptopGPU As LaptopGPU = db.LaptopGPUs.Find(id)
            If IsNothing(laptopGPU) Then
                Return HttpNotFound()
            End If
            Return View(laptopGPU)
        End Function

        ' POST: LaptopGPUs/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim laptopGPU As LaptopGPU = db.LaptopGPUs.Find(id)
            db.LaptopGPUs.Remove(laptopGPU)
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
