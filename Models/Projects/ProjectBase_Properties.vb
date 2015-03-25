Imports System
Imports System.Runtime.Serialization
Imports DotNetNuke.ComponentModel.DataAnnotations
Imports Connect.DNN.Modules.Projects.Common

Namespace Models.Projects
 <TableName("Connect_Projects_Projects")>
 <PrimaryKey("ProjectId", AutoIncrement:=True)>
 <DataContract()>
 <Scope("ModuleId")>
 Partial Public Class ProjectBase
  Inherits AuditableEntity

#Region " Private Members "
#End Region

#Region " Constructors "
  Public Sub New()
  End Sub

  Public Sub New(projectId As Int32, aims As String, moduleId As Int32, createdByUserID As Int32, createdOnDate As Date, dependencies As String, description As String, lastModifiedByUserID As Int32, lastModifiedOnDate As Date, owners As String, projectName As String, projectType As Int32, status As String, url1 As String, url2 As String, visible As Boolean)
   Me.Aims = aims
   Me.ModuleId = moduleId
   Me.CreatedByUserID = createdByUserID
   Me.CreatedOnDate = createdOnDate
   Me.Dependencies = dependencies
   Me.Description = description
   Me.LastModifiedByUserID = lastModifiedByUserID
   Me.LastModifiedOnDate = lastModifiedOnDate
   Me.Owners = owners
   Me.ProjectId = projectId
   Me.ProjectName = projectName
   Me.ProjectType = projectType
   Me.Status = status
   Me.Url1 = url1
   Me.Url2 = url2
   Me.Visible = visible
  End Sub
#End Region

#Region " Public Properties "
  <DataMember()>
  Public Property Aims As String = ""
  <DataMember()>
  Public Property ModuleId As Int32 = -1
  <DataMember()>
  Public Property Dependencies As String = ""
  <DataMember()>
  Public Property Description As String = ""
  <DataMember()>
  Public Property Owners As String = ""
  <DataMember()>
  Public Property ProjectId As Int32 = -1
  <DataMember()>
  Public Property ProjectName As String = ""
  <DataMember()>
  Public Property ProjectType As Int32 = -1
  <DataMember()>
  Public Property Status As String = ""
  <DataMember()>
  Public Property Url1 As String = ""
  <DataMember()>
  Public Property Url2 As String = ""
  <DataMember()>
  Public Property Visible As Boolean = False
#End Region

#Region " Methods "
  Public Sub ReadProjectBase(project As ProjectBase)
   If project.Aims IsNot Nothing Then Aims = project.Aims
   If project.Dependencies IsNot Nothing Then Dependencies = project.Dependencies
   If project.Description IsNot Nothing Then Description = project.Description
   If project.Owners IsNot Nothing Then Owners = project.Owners
   If project.ProjectName IsNot Nothing Then ProjectName = project.ProjectName
   If project.ProjectType > -1 Then ProjectType = project.ProjectType
   If project.Status IsNot Nothing Then Status = project.Status
   If project.Url1 IsNot Nothing Then Url1 = project.Url1
   If project.Url2 IsNot Nothing Then Url2 = project.Url2
  End Sub
#End Region

 End Class
End Namespace


