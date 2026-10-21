# Text Styler API - Ruby Gem

Text Styler converts plain text into styled text formats like bubble letters, strikethrough, typewriter, and vaporwave. Submit your string with a chosen style to receive the formatted text output.

## Installation

Add this line to your application's Gemfile:

```ruby
gem 'apiverve_textstyler'
```

And then execute:

```bash
$ bundle install
```

Or install it yourself as:

```bash
$ gem install apiverve_textstyler
```

## Getting Started

Get your API key at [APIVerve](https://apiverve.com)

### Basic Usage

```ruby
require 'apiverve_textstyler'

# Initialize the client
client = APIVerve::Textstyler::Client.new(api_key: "YOUR_API_KEY")

# Make a request
response = client.execute({
  text: "This is a very stylish piece of text",
  style: "bubbles"
})

# Print the response
puts response
```


### Error Handling

```ruby
begin
  response = client.execute({ text: "This is a very stylish piece of text", style: "bubbles" })
  puts response["data"]
rescue APIVerve::Textstyler::ValidationError => e
  puts "Validation error: #{e.errors.join(', ')}"
rescue APIVerve::Textstyler::APIError => e
  puts "API error: #{e.message}"
  puts "Status code: #{e.status_code}"
end
```

### Debug Mode

```ruby
# Enable debug logging
client = APIVerve::Textstyler::Client.new(
  api_key: "YOUR_API_KEY",
  debug: true
)
```

## Example Response

```json
{
  "status": "ok",
  "error": null,
  "data": {
    "style": "bubbles",
    "text": "Ⓣⓗⓘⓢ ⓘⓢ ⓐ ⓥⓔⓡⓨ ⓢⓣⓨⓛⓘⓢⓗ ⓟⓘⓔⓒⓔ ⓞⓕ ⓣⓔⓧⓣ"
  }
}
```

## Documentation

For more information, visit the [API Documentation](https://docs.apiverve.com/ref/textstyler?utm_source=rubygems&utm_medium=referral&utm_content=readme).

## Support

- Website: [https://apiverve.com/marketplace/textstyler?utm_source=ruby&utm_medium=referral&utm_content=readme](https://apiverve.com/marketplace/textstyler?utm_source=ruby&utm_medium=referral&utm_content=readme)
- Email: hello@apiverve.com

## License

This gem is available under the [MIT License](LICENSE).
