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
    Public Class LaptopCPUsController
        Inherits System.Web.Mvc.Controller

        Private db As New SQLServerDBEntities1

        ' GET: LaptopCPUs
        Function Index() As ActionResult
            Return View(db.LaptopCPUs.ToList())
        End Function

        ' GET: LaptopCPUs/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim laptopCPU As LaptopCPU = db.LaptopCPUs.Find(id)
            If IsNothing(laptopCPU) Then
                Return HttpNotFound()
            End If
            Return View(laptopCPU)
        End Function

        ' GET: LaptopCPUs/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: LaptopCPUs/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="LaptopCPUID,Brand,NumberOfCores,Frequency_mHz")> ByVal laptopCPU As LaptopCPU) As ActionResult
            If ModelState.IsValid Then
                db.LaptopCPUs.Add(laptopCPU)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(laptopCPU)
        End Function

        ' GET: LaptopCPUs/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim laptopCPU As LaptopCPU = db.LaptopCPUs.Find(id)
            If IsNothing(laptopCPU) Then
                Return HttpNotFound()
            End If
            Return View(laptopCPU)
        End Function

        ' POST: LaptopCPUs/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="LaptopCPUID,Brand,NumberOfCores,Frequency_mHz")> ByVal laptopCPU As LaptopCPU) As ActionResult
            If ModelState.IsValid Then
                db.Entry(laptopCPU).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(laptopCPU)
        End Function

        ' GET: LaptopCPUs/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim laptopCPU As LaptopCPU = db.LaptopCPUs.Find(id)
            If IsNothing(laptopCPU) Then
                Return HttpNotFound()
            End If
            Return View(laptopCPU)
        End Function

        ' POST: LaptopCPUs/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim laptopCPU As LaptopCPU = db.LaptopCPUs.Find(id)
            db.LaptopCPUs.Remove(laptopCPU)
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
