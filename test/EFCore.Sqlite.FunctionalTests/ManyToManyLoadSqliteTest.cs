// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore;

public class ManyToManyLoadSqliteTest(ManyToManyLoadSqliteTest.ManyToManyLoadSqliteFixture fixture)
    : ManyToManyLoadSqliteTestBase<ManyToManyLoadSqliteTest.ManyToManyLoadSqliteFixture>(fixture)
{
    public class ManyToManyLoadSqliteFixture : ManyToManyLoadSqliteFixtureBase;
}
