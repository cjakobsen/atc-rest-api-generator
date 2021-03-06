<div style='text-align: right'>

[References](Index.md)&nbsp;&nbsp;-&nbsp;&nbsp;[References extended](IndexExtended.md)
</div>

# Atc.Rest.ApiGenerator.Factories

<br />


## ProjectApiClientFactory

```csharp
public static class ProjectApiClientFactory
```

### Static Methods


#### CreateUsingListForEndpoint

```csharp
string[] CreateUsingListForEndpoint(ApiProjectOptions apiProjectOptions, bool includeRestResults, bool hasParameter, bool hasList, bool hasSharedModel)
```
#### CreateUsingListForEndpointInterface

```csharp
string[] CreateUsingListForEndpointInterface(ApiProjectOptions apiProjectOptions, bool includeRestResults, bool hasList, bool hasSharedModel)
```
#### CreateUsingListForEndpointResult

```csharp
string[] CreateUsingListForEndpointResult(ApiProjectOptions apiProjectOptions, bool includeRestResults, bool hasList, bool hasSharedModel)
```
#### CreateUsingListForEndpointResultInterface

```csharp
string[] CreateUsingListForEndpointResultInterface(ApiProjectOptions apiProjectOptions, bool includeRestResults, bool hasList, bool hasSharedModel)
```

<br />


## ProjectApiFactory

```csharp
public static class ProjectApiFactory
```

### Static Methods


#### CreateUsingListForContractInterface

```csharp
string[] CreateUsingListForContractInterface()
```
#### CreateUsingListForContractModel

```csharp
string[] CreateUsingListForContractModel(OpenApiSchema apiSchema)
```
#### CreateUsingListForContractParameter

```csharp
string[] CreateUsingListForContractParameter(IList<OpenApiParameter> globalParameters, IList<OpenApiParameter> parameters, OpenApiRequestBody requestBody, bool forClient)
```
#### CreateUsingListForContractResult

```csharp
string[] CreateUsingListForContractResult(OpenApiResponses responses, bool useProblemDetailsAsDefaultResponseBody)
```
#### CreateUsingListForEndpoint

```csharp
string[] CreateUsingListForEndpoint(ApiProjectOptions apiProjectOptions, string focusOnSegmentName, List<OpenApiOperation> apiOperations, bool includeRestResults, bool hasSharedModel)
```

<br />


## ProjectDomainFactory

```csharp
public static class ProjectDomainFactory
```

### Static Methods


#### CreateUsingListForHandler

```csharp
string[] CreateUsingListForHandler(DomainProjectOptions domainProjectOptions, string focusOnSegmentName)
```

<br />


## ProjectHostFactory

```csharp
public static class ProjectHostFactory
```

### Static Methods


#### CreateUsingListForProgram

```csharp
string[] CreateUsingListForProgram()
```
#### CreateUsingListForStartup

```csharp
string[] CreateUsingListForStartup(string projectName, bool useExtended)
```
#### CreateUsingListForWebApiControllerBaseTest

```csharp
string[] CreateUsingListForWebApiControllerBaseTest()
```
#### CreateUsingListForWebApiStartupFactory

```csharp
string[] CreateUsingListForWebApiStartupFactory(string projectName)
```
<hr /><div style='text-align: right'><i>Generated by MarkdownCodeDoc version 1.2</i></div>
