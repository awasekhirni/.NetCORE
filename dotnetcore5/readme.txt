# .net core 5 web api codeplay
Awase Khirni Syed awase008@gmail.com 2021 Elain Technologies Canada Inc 
1.cleanarchone => monolithic application using dotnetcore 5.x 
   # unlike asp.net core 3.x dotnet core 5 automatically installs swashbuckle for rendering json webapi. In asp.net core 3.x we had to explicitly install using nuget package manager
   #Add-Migrations still exists similar to asp.net core 3.x and seeding as well. 
2.multi-layer clean architecture demo => 
    
    Playbook for Creating a Multi-layer Asp.Net Core 5 Web Api Application
a. Create a blank Solution => MultilayerAppdemoTwo 
b. Create a new standard library => ProductCatalog.Domain => DomainModels 
    i. create CatalogBrand Model 
	ii. create CatalogType 
	iii. create CatalogItem
c. Create a new standard Library => ProductCatalog.Repository => Repository Interfaces 
     => Dependencies => add ProductCatalog.Domain 
	 i. create ICatalogItemRepository.cs 
	 ii. create ICatalogBrandRepository.cs 
	 iii. create ICatalogTypeRepository.cs 
	 
	 
 public interface ICatalogBrandRepository
    {
        Task<IEnumerable<CatalogBrand>> GetCatalogItemsAsync();
        Task<CatalogBrand> GetCatalogBrandDetailsAsync(int id);

        Task<CatalogBrand> AddAsync(CatalogBrand item);

        Task UpdateAsync(CatalogBrand item);

        Task DeleteAsync(int id);
    }
	
	
	 public interface ICatalogItemRepository
    {
        Task<IEnumerable<CatalogItem>> GetCatalogItemsAsync();
        Task<CatalogItem> GetCatalogItemDetailsAsync(int id);

        Task<CatalogItem> AddAsync(CatalogItem item);

        Task UpdateAsync(CatalogItem item);

       Task DeleteAsync(int id);

    }
	
	public interface ICatalogTypeRepository
    {
        Task<IEnumerable<CatalogType>> GetCatalogItemsAsync();
        Task<CatalogType> GetCatalogTypeDetailsAsync(int id);

        Task<CatalogType> AddAsync(CatalogType item);

        Task UpdateAsync(CatalogType item);

        Task DeleteAsync(int id);

    }
	 
d. Create a new standard Library => ProductCatalog.EFRepository => Implementation of the interfaces here 
   # the intent is to keep the entity framework implementations as a separate layer, in the event we would like to use Dapper Framework or ADO.Net 
   this would provide some flexibility 
   => Dependencies => add ProductCatalog.Repository 
   => Install Miscrosoft Entity Framework core using NugetPackage Manager 
    => Create a folder => context => ProductCatalogAPIContext, ProductCatalogSeed
		
   Implement => i. CatalogItemRepository using ProductCatalogAPIContext
			ii. CatalogBrandRepository using ProductCatalogAPIContext
			iii. CatalogTypeRepository using ProductCatalogAPIContext

e.Create a new standard Library => ProductCatalog.BusinessObjects => Business Layer Logic 
    # create interfaces and then implementations of the domain objects for BLL 
	=> Dependenies => add ProductCatalog.Repository and ProductCatalog.Domain 
	  => Interface a.ICatalogItemBO.cs b.ICatalogBrandBo.cs c.ICatalogTypeBO.cs 
	  
f. Create a new project => Web API => ProductCatalog.WebAPI => JSON WebAPI using swashbuckle 
   => dependences => ProductCatalog.BusinessObjects , EFRepository and Repository 
     <ItemGroup>
    <ProjectReference Include="..\ProductCatalog.BusinessObjects\ProductCatalog.BusinessObjects.csproj" />
    <ProjectReference Include="..\ProductCatalog.EFRepository\ProductCatalog.EFRepository.csproj" />
    <ProjectReference Include="..\ProductCatalog.Repository\ProductCatalog.Repository.csproj" />
  </ItemGroup>
  
  Install-Package Microsoft.EntityFrameworkCore.SqlServer
  
 => create API controllers using BusinessObjects Interfaces 
      => CatalogItemsController, CatalogBrandsController, CatalogTypesController 
	  
	  Register dependent services in startup.cs 
	    services.addtransient()
      
g. Go to Package Manager Console 
Add-Migration "Initial Script"

##
#3. Clean Architecture for dotnetcore 5 applications demo 
