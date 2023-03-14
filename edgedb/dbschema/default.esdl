module default {
    type Company {
        required property name -> str;
    }
    
    type Interest {
        required property name -> str;
    }

    type Person {
        required property name -> str;
        multi link Companies -> Company {
            property employment_start -> cal::local_date;
            property employment_end -> cal::local_date;
        }
        multi link Interests -> Interest
    }
}
