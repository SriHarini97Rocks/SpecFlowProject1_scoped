taskkill /IM cmd.exe
livingdoc test-assembly "$TestAssemblyPath" --test-execution-json "$TestExecutionPath" --output-type HTML --output "$HtmlReportPath" --title "$TestTitle"