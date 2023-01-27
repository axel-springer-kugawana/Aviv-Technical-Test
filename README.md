# AVIV technical test

This repository contains the technical test that you are expected to fulfill. It contains multiple folders, depending
on the position you applied to.

Take 5 minutes to read this README.md entirely 🙏

## 1. A bit of context

At AVIV, we often deal with _listings_. A listing is the description of a real estate that can be rented or bought. It
contains information such as price and availability. We also display real estates characteristics, such as its category
or size.

It has been decided by the product team to provide a view of our listings to our customer. Specifically, we want to display
a list of each listing we have in our database, with its price history. The technical team, has determined that a REST
API should be developed to provide the listings, so they can be displayed on a single page application. Developers have
already started to provide a resource endpoint to retrieve, create and update such listings in an API called the
`ListingAPI`.

The ListingAPI has a schema that is documented in the [schemas/listingapi.yaml](./schemas/listingapi.yaml) folder.

Note that you can upload the YAML file to [ReDoc](https://redocly.github.io/redoc/) to read it comfortably.

## 2. Before starting

You will need [`Docker`](https://www.docker.com/) and [`docker-compose`](https://docs.docker.com/compose/) to run this test.

All backend tests provide an implementation of the `ListingAPI`. The front-end test provides an implementation that
consumes it. Before digging into the test, please note the following expectations:

- You shall allocate around **90 minutes** on this test, including the discovery phase;
- During the development phase, be sure to **write down your assumptions** and any other development you were not
  able to achieve, in the [SOLUTION.md](./SOLUTION.md) file.

The aim of the technical is to serve as a base for a debrief, in which you will defend your choices, and discuss what is
missing in your implementation.

## 3. The exercise

### Front-end expectations

**If you applied to a front-end position**, you can continue by reading the README.md in the front-end test directory.

### Back-end expectations

**If applied to a backend position**, you are expected to write the code, so we can, for a specific listing,
see all the prices that was given to it.

A Postman collection is available on the [Schemas directory](./schemas/postman). You can import it directly and run
API calls by choosing your environment (`Python Flask`, `C# .NET` or `Typescript Serverless`).

For instance, you can consider this simple scenario:

- a listing is created using the API, with a specified price `100000`

```
POST /listings

{
    ...
    "latest_price_eur": 100000
    ...
}
```

- the listing is updated using the API, with a new price `200000` 📈

```
PUT /listings/<id>

{
    ...
    "latest_price_eur": 200000
    ...
}
```

- the listing is updated again using the API, with a new price `175000` 📉

```
PUT /listings/<id>

{
    ...
    "latest_price_eur": 175000
    ...
}
```

- when trying to retrieve the prices for this specific listing, we should see three prices listed:

```
GET /listings/<id>/prices

[
    { price_eur: 100000, created_date: "<creation date>" },
    { price_eur: 200000, created_date: "<first update date>" },
    { price_eur: 175000, created_date: "<second update date>" }
]
```

You can continue by reading the README.md in the back-end test directory of the language of your choice.

You have several flavors available:
- [Python Flask](./python-flask)
- [TypeScript Serverless](./typescript-serverless)
- [C# .NET](./c#-dotnet)

You must pick the one that is relevant to the position your applying to.

## 4. When you're done

Send us a `.zip` file with commits history (keep the `.git` folder). The file should include
- the `.git/` folder;
- the entire codebase;
- this SOLUTION.md file, with the answers to the questions written above.

If you want to join any additional file, you can add them to the archive and link them here.
