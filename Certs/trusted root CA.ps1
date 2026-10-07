# Recreate + trust the dev cert
dotnet dev-certs https --check --verbose
dotnet dev-certs https --clean
dotnet dev-certs https --trust --verbose


# If still untrusted, import the cert into Trusted Root manually
# Run certmgr.msc -> Personal -> Certificates -> find the ASP.NET Core dev cert (subject CN=localhost) -> Export (DER/BASE64) -> Import into # Trusted Root Certification Authorities (Current User).