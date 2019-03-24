# ib-flex-reader

This library can help you with fetching flex queries from Interactive Brokers.
Just pass Token and Query ID and wait until it has finished.

[![Build Status](https://travis-ci.org/gabbersepp/ib-flex-reader.svg?branch=master)](https://travis-ci.org/gabbersepp/ib-flex-reader)

## Usage

Simple call the library by passing your token and queryId:

```c#
	...
	FlexResult result = new Reader().GetByApi(token, queryId).Result;
	...
```

Or pass an already downloaded file:

```c#
	...
	FlexQueryResponse result = new Reader().GetByString(content);
	...
```

## Install
Search it on nuget.com

## Requirements
It requires your application to be .NET Standard 2.0 compliant.

## IB Setup
Please read the wiki to be informed about the required IB setup.

## [Release Notes](https://github.com/gabbersepp/ib-flex-reader/blob/master/CHANGELOG.md)

