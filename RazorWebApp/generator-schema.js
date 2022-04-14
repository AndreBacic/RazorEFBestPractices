source_generator = "https://json-generator.com/#"
schema =
[
  "{{repeat(12)}}",
  {
    "FirstName": "{{firstName()}}",
    "LastName": "{{surname()}}",
    "Age": function (tags) {
      return Math.floor(tags.integer(1, 7) * tags.integer(1, 7) + tags.integer(15, 31));
    },
    "Emails": [
      "{{repeat(1, 3)}}",
      {
        "EmailAddress": "{{email(true)}}"
      }
    ],
    "Address": {
      "Street": "{{integer(100, 9999)}} {{street()}}",
      "City": "{{city()}}",
      "State": "{{state()}}",
      "ZipCode": "{{integer(10000,99999)}}-{{integer(1000,9999)}}"
    },
    "Tasks": [
      "{{repeat(0, 6)}}",
      {
        "Title": "{{lorem(1)}}",
        "Description": "{{lorem(1, \"paragraphs\")}}",
        "StartDate": '{{date(new Date(2012, 0, 1), new Date(), "YYYY-MM-ddT11:45:50")}}',
        "EndDate": '{{date(new Date(2012, 0, 1), new Date(), "YYYY-MM-ddT11:45:50")}}',
        "Priority": "{{integer(1, 4)}}"
      }
    ]
  }
]
