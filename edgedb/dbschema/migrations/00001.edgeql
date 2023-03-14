CREATE MIGRATION m1bfne7ncw7h2sxusb35bhyapuotif3tcr55e57ih2athqcuf4zq7q
    ONTO initial
{
  CREATE FUTURE nonrecursive_access_policies;
  CREATE TYPE default::Company {
      CREATE REQUIRED PROPERTY name -> std::str;
  };
  CREATE TYPE default::Interest {
      CREATE REQUIRED PROPERTY name -> std::str;
  };
  CREATE TYPE default::Person {
      CREATE MULTI LINK Companies -> default::Company {
          CREATE PROPERTY employment_end -> cal::local_date;
          CREATE PROPERTY employment_start -> cal::local_date;
      };
      CREATE MULTI LINK Interests -> default::Interest;
      CREATE REQUIRED PROPERTY name -> std::str;
  };
};
