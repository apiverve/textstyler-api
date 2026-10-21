# Text Styler API - PHP Package

Text Styler converts plain text into styled text formats like bubble letters, strikethrough, typewriter, and vaporwave. Submit your string with a chosen style to receive the formatted text output.

## Installation

Install via Composer:

```bash
composer require apiverve/textstyler
```

## Getting Started

Get your API key at [APIVerve](https://apiverve.com)

### Basic Usage

```php
<?php

require_once 'vendor/autoload.php';

use APIVerve\Textstyler\Client;

// Initialize the client
$client = new Client('YOUR_API_KEY');

// Make a request
$response = $client->execute([
    'text' => 'This is a very stylish piece of text',
    'style' => 'bubbles'
]);

// Print the response
print_r($response);
```


### Error Handling

```php
use APIVerve\Textstyler\Client;
use APIVerve\Textstyler\Exceptions\APIException;
use APIVerve\Textstyler\Exceptions\ValidationException;

try {
    $response = $client->execute(['text' => 'This is a very stylish piece of text', 'style' => 'bubbles']);
    print_r($response['data']);
} catch (ValidationException $e) {
    echo "Validation error: " . implode(', ', $e->getErrors());
} catch (APIException $e) {
    echo "API error: " . $e->getMessage();
    echo "Status code: " . $e->getStatusCode();
}
```

### Debug Mode

```php
// Enable debug logging
$client = new Client(
    apiKey: 'YOUR_API_KEY',
    debug: true
);
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

## Requirements

- PHP 7.4 or higher
- Guzzle HTTP client

## Documentation

For more information, visit the [API Documentation](https://docs.apiverve.com/ref/textstyler?utm_source=packagist&utm_medium=referral&utm_content=readme).

## Support

- Website: [https://apiverve.com/marketplace/textstyler?utm_source=php&utm_medium=referral&utm_content=readme](https://apiverve.com/marketplace/textstyler?utm_source=php&utm_medium=referral&utm_content=readme)
- Email: hello@apiverve.com

## License

This package is available under the [MIT License](LICENSE).
