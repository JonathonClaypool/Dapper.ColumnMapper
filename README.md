
# Dapper.ColumnMapper

[![NuGet Version](https://img.shields.io/nuget/v/Dapper.ColumnMapper)](https://www.nuget.org/packages/Dapper.ColumnMapper/)
[![Build Status](https://img.shields.io/github/actions/workflow/status/yourusername/Dapper.ColumnMapper/build.yml?branch=main)](https://github.com/yourusername/Dapper.ColumnMapper/actions)
[![License](https://img.shields.io/github/license/yourusername/Dapper.ColumnMapper)](LICENSE)

An extension library for [Dapper](https://github.com/DapperLib/Dapper) that enables attribute-based mapping of database column names to class properties using custom attributes. This simplifies data access code by eliminating the need for manual property mappings.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Installation](#installation)
- [Usage](#usage)
    - [Defining Models](#defining-models)
    - [Registering Type Maps](#registering-type-maps)
    - [Executing Queries](#executing-queries)
- [Examples](#examples)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgments](#acknowledgments)

## Features

- Attribute-based mapping using `[ColumnName("db_column_name")]`
- Automatic type map registration for Dapper
- Eliminates the need for manual property mappings
- Compatible with standard Dapper methods (`Query`, `Execute`, etc.)
- Supports .NET Framework, .NET Core, and .NET 5/6+

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (.NET Core 3.1 or later recommended)
- [Dapper](https://www.nuget.org/packages/Dapper/) installed
- SQL Server or any other database supported by Dapper

### Installation

Install the `Dapper.ColumnMapper` package via NuGet Package Manager:

```shell
Install-Package Dapper.ColumnMapper
