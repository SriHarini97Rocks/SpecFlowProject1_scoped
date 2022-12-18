taskkill /IM cmd.exe /f
livingdoc test-assembly "$TestAssemblyPath" --test-execution-json "$TestExecutionPath" --output-type HTML --output "$HtmlReportPath" --title "$TestTitle"