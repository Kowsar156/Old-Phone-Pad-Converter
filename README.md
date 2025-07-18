# Old Phone Keypad Converter

This C# application is an implementation for converting old button phone keypad inputs into readable text output.

## Setting Up, Running & Testing procedure

1. Clone the repository:
```bash
git clone https://github.com/Kowsar156/Old-Phone-Pad-Converter.git
cd Old-Phone-Pad-Converter
```

2. Build the project:
```bash
cd OldPhonePad
dotnet build
```

3. Run the application:
```bash
dotnet run
```

## Running Tests

Run all tests from the root project folder (Old-Phone-Pad-Converter):
```bash
dotnet test PhonePadConverterTests
```

## Features

- Converts button phone key typing sequnces into meaningful messages
- You can also type numbers
- Supports space and some special characters
- Typing '*' means backspace
- Type '#' to send the message (ends the text)

## Button to Character Mapping

```
- 0: Space
- 1: &'(
- 2: abc
- 3: def
- 4: ghi
- 5: jkl
- 6: mno
- 7: pqrs
- 8: tuv
- 9: wxyz
```
You can also type a number by pressing the key again after the last character of the key. Press again, the characters start in the same sequence again.

## Example

- "33#" → "e"
- "227*#" → "b"
- "4433555 555666#" → "hello"
- "8 88777444666*664#" → "turing"
