# EdgeDB Demo

This is a playground repo to toy with EdgeDB for a bit. It provides a Razor/ASP.NET application that allows the user to explore the database according to the schema.

## Schema

*Person*
- has a `name`
- is related to multiple Companies with `@employment_start` and `@employment_end`
- is related to multiple Interests

*Company*
- has a `name`
- has an `address`

*Interest*
- has a `name`

## Getting up and running
1. Ensure that the EdgeDB CLI is installed
2. Setup a new instance (if you pick `famous_people` you don't have to change it in the code later on)
3. Restore the backup with `edgedb restore -I {instance_name} /path/to/famous_people.tmp`
4. cd into the **EdgeDB-Demo** directory and `dotnet run` (you may have to change the instance name in `Program.cs` if you picked a different one

## Known issues
- The deserializer for Company doesn't account for address not being set in the result
- When querying a Person (on /person/{uuid}) the deserializer tries to create Company objects where Interest objects should be created *This is probably a bug in the Client Library*
