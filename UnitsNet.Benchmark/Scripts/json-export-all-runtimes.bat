@echo off
SET scriptdir=%~dp0
SET projectdir="%scriptdir%..\.."
SET exportdir="%projectdir%\Artifacts\Benchmark"
:: this fails on the build server (also tested with the nightly benchmark.net package: 0.12.1.1533): possibly related to https://github.com/dotnet/BenchmarkDotNet/issues/1487
dotnet run --project "%projectdir%/UnitsNet.Benchmark" -c Release ^
--framework net8.0 ^
--runtimes net48 net8.0 ^
--artifacts=%exportdir% ^
--exporters json ^
--filter * ^
--iterationTime 250 ^
--statisticalTest 0.001ms ^
--join %1 %2 %3

:: this runs fine, however there is currently no way of displaying multiple-lines-per-chart: see https://github.com/rhysd/github-action-benchmark/issues/18
:: dotnet run --project "%scriptdir%/UnitsNet.Benchmark" -c Release -f net8.0 --runtimes net48 net8.0 --filter ** --artifacts="%scriptdir%/Artifacts/Benchmark" --exporters json
