﻿using FC.Codeflix.Catalog.EndToEndTests.Api.Category.Common;
using Xunit;

namespace FC.Codeflix.Catalog.EndToEndTests.Api.Category.DeleteCategory;
[CollectionDefinition(nameof(DeleteCategoryApiTestFixture))]
public class DeleteCategoryApiTestFixtureFixtureCollection : ICollectionFixture<DeleteCategoryApiTestFixture> { }

public class DeleteCategoryApiTestFixture : CategoryBaseFixture
{

}