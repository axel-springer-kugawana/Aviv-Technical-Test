import PostgresClient from "serverless-postgres";

export const postgres = new PostgresClient({
  application_name: "listingapi-typescript",
  host: process.env.PGHOST || "localhost", // should be fine for testing purposes
  database: process.env.PGDATABASE || "listing",
  user: process.env.PGUSER || "listing",
  password: process.env.PGPASSWORD || "listing",
});

/**
 * Utility function to turn a dictionnary to a set of
 * rows, variables and values for selecting, inserting or updating
 * data in a table.
 */
export function extractVariables(row: object) {
  const columns = [];
  const variables = [];
  const columnsVariables = [];
  const values = [];

  for (const [index, [column, value]] of Object.entries(row).entries()) {
    columns.push(column);

    const variable = `$${index + 1}`;
    variables.push(variable);
    columnsVariables.push(`${column} = ${variable}`);

    values.push(value);
  }

  return { columns, variables, columnsVariables, values };
}
