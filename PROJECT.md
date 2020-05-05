# ib-flex-reader

This library can help you with fetching flex queries from Interactive Brokers.

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
