# Release History

## 1.0.0-beta.5 (Unreleased)

### Features Added

### Breaking Changes

### Bugs Fixed

### Other Changes
- Updated Microsoft.Identity.Client.Broker and Microsoft.Identity.Client.Extensions.Msal dependencies to version 4.56.0

## 1.0.0-beta.4 (2023-07-17)

### Features Added

- Added support for MSA passthrough. Note this is only available for legacy 1st party applications.

## 1.0.0-beta.3 (2022-08-09)

### Breaking Changes
- Added required constructor parameter `parentWindowHandle` to `InteractiveBrowserCredentialBrokerOptions`, to require setting the parent window for the authentication broker.

## 1.0.0-beta.2 (2022-04-05)

### Features Added
- Added `SharedTokenCacheCredentialBrokerOptions` to enable `SharedTokenCacheCredential` to use the authentication broker for silent authentication calls when this specicialized options type is used to construct the credential.

## 1.0.0-beta.1 (2022-02-23)

### Features Added
- Added `InteractiveBrowserCredentialBrokerOptions` to enable `InteractiveBrowserCredential` to use the authentication broker when this specicialized options type is used to construct the credential.
