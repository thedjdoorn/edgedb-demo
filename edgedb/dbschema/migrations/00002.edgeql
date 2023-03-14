CREATE MIGRATION m1srlqpugdwkfgz6zgqopz6hv4c6rqrcvhhzkkm6rle2uwzudcqqsa
    ONTO m1bfne7ncw7h2sxusb35bhyapuotif3tcr55e57ih2athqcuf4zq7q
{
  ALTER TYPE default::Company {
      CREATE REQUIRED PROPERTY address -> std::str {
          SET REQUIRED USING ('No Address');
      };
  };
};
