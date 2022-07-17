@echo off
REM Prepare Environment
kubectl config use-context docker-desktop

REM Uninstall Application fromt Kubernetes using CLI
kubectl delete -f frontend.yml
kubectl delete -f backend.yml
kubectl delete -f defaults.yml
kubectl delete namespace prototype

REM Uninstall Consul from Kubernetes using Helm
helm uninstall consul
kubectl delete namespace consul