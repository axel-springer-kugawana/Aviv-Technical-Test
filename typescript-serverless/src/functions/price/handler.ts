import { functionHandler } from "@/libs/function";
import { getRepository } from "@/repositories/listings";
import { NotFound } from "@/libs/errors";
import { Price } from "@/types.generated";

export const getListingPrices = functionHandler<Price[]>(
  async (event, context) => {
    const listingId = parseInt(event.pathParameters.id);

    if (isNaN(listingId)) {
      throw new NotFound("Invalid listing ID");
    }

    const repository = getRepository(context.postgres);

    const priceHistory = await repository.getListingPriceHistory(listingId);

    if (!priceHistory.length) {
      throw new NotFound(`No price history found for listing ID ${listingId}`);
    }

    return {
      statusCode: 200,
      response: priceHistory,
    };
  }
);
