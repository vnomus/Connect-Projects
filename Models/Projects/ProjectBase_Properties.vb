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

  Public Sub New(projectId As Int32, aims As String, moduleId As Int32, createdByUserID As Int32, createdOnDate As Date, dependencies As String, description As String, firstImage As String, lastModifiedByUserID As Int32, lastModifiedOnDate As Date, owners As String, people As String, projectName As String, projectType As Int32, status As String, url1 As String, url2 As String, visible As Boolean)
   Me.Aims = aims
   Me.ModuleId = moduleId
   Me.CreatedByUserID = createdByUserID
   Me.CreatedOnDate = createdOnDate
   Me.Dependencies = dependencies
   Me.Description = description
   Me.FirstImage = firstImage
   Me.LastModifiedByUserID = lastModifiedByUserID
   Me.LastModifiedOnDate = lastModifiedOnDate
   Me.Owners = owners
   Me.People = people
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
  Public Property FirstImage As String = ""
  <DataMember()>
  Public Property Owners As String = ""
  <DataMember()>
  Public Property People As String = ""
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
   If project.ModuleId > -1 Then ModuleId = project.ModuleId
   If project.CreatedByUserID > -1 Then CreatedByUserID = project.CreatedByUserID
   If Not project.CreatedOnDate = Date.MinValue Then CreatedOnDate = project.CreatedOnDate
   If project.Dependencies IsNot Nothing Then Dependencies = project.Dependencies
   If project.Description IsNot Nothing Then Description = project.Description
   If project.LastModifiedByUserID > -1 Then LastModifiedByUserID = project.LastModifiedByUserID
   If Not project.LastModifiedOnDate = Date.MinValue Then LastModifiedOnDate = project.LastModifiedOnDate
   If project.Owners IsNot Nothing Then Owners = project.Owners
   If project.People IsNot Nothing Then People = project.People
   If project.ProjectId > -1 Then ProjectId = project.ProjectId
   If project.ProjectName IsNot Nothing Then ProjectName = project.ProjectName
   If project.ProjectType > -1 Then ProjectType = project.ProjectType
   If project.Status IsNot Nothing Then Status = project.Status
   If project.Url1 IsNot Nothing Then Url1 = project.Url1
   If project.Url2 IsNot Nothing Then Url2 = project.Url2
   Visible = project.Visible
  End Sub
#End Region

 End Class
End Namespace


