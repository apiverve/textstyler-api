from setuptools import setup, find_packages

setup(
    name='apiverve_textstyler',
    version='1.2.2',
    packages=find_packages(),
    include_package_data=True,
    install_requires=[
        'requests',
        'setuptools'
    ],
    description='Text Styler converts plain text into styled text formats like bubble letters, strikethrough, typewriter, and vaporwave. Submit your string with a chosen style to receive the formatted text output.',
    author='APIVerve',
    author_email='hello@apiverve.com',
    url='https://apiverve.com/marketplace/textstyler?utm_source=pypi&utm_medium=referral&utm_content=homepage',
    classifiers=[
        'Programming Language :: Python :: 3',
        'Operating System :: OS Independent',
    ],
    python_requires='>=3.6',
)
