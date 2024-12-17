import { functionHandler } from "@/libs/function";
import { getRepository } from "@/repositories/listings";
import { Listing, ListingWrite } from "@/types.generated";
import { EntityNotFound, NotFound } from "@/libs/errors";

export const getListings = functionHandler<Listing[]>(
  async (_event, context) => {
    const listings = await getRepository(context.postgres).getAllListings();

    return { statusCode: 200, response: listings };
  }
);

export const addListing = functionHandler<Listing, ListingWrite>(
  async (event, context) => {
    const listing = await getRepository(context.postgres).insertListing(
      event.body
    );

    return { statusCode: 201, response: listing };
  }
);

export const updateListing = functionHandler<Listing, ListingWrite>(
  async (event, context) => {
    const listingId = parseInt(event.pathParameters.id);
    const updates = event.body;

    const repository = getRepository(context.postgres);

    try {
      const existingListing = await repository.getListing(listingId);

      if (updates.latest_price_eur !== existingListing.latest_price_eur) {
        await repository.addPriceHistory(listingId, updates.latest_price_eur);
      }

      const updatedListing = await repository.updateListing(listingId, updates);

      return { statusCode: 200, response: updatedListing };
    } catch (e) {
      if (e instanceof EntityNotFound) {
        throw new NotFound(e.message);
      }
      throw e;
    }
  }
);
